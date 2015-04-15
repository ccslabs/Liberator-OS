#
# mcmkup.ps1 version 0.33 20110727
# Created by Marcello Gorlani
# http://www.gorlani.com/portal/
#
# You can freely use and distribute this junk as long you leave this credits
# This software comes with no warranty. It may destroy life on the Earth as we know it. Be warned.
#

$CLUTTER_STUFF="`nmcmkup.ps1 0.33 20110727 by Marcello Gorlani`n"

# Me-big-hacker super-secret key and value. See http://technet.microsoft.com/en-us/library/cc780532(WS.10).aspx
$REGKEY='HKLM:\SYSTEM\CurrentControlSet\Control\Class\{4D36E972-E325-11CE-BFC1-08002BE10318}'
$VALUE_NAME='NetworkAddress'

$LOOKUP_REGKEY='HKLM:\SYSTEM\CurrentControlSet\Control\Network\{4D36E972-E325-11CE-BFC1-08002BE10318}'

# This will be used to identify physical NICs
$NCF_PHYSICAL=4

# Various parsing parameters
$CMD_MIN_LEN=3
$MIN_CMD_TOKS=1
$QUITCMD='quit'

# For minimal validity checks
$GOOD_MAC_LEN=12

# Why bother about errors if you can hide them?
$ErrorActionPreference="SilentlyContinue"

######################################################################
# Global variables                                                   #
######################################################################

# By default, we DO NOT powercycle the interface after spoofing. Set this to $true to have the opposite default
[boolean] $global:bCycleInterface=$false

# Follow my lips: N-O
[boolean] $global:bIdontKnowWhatImDoingAndWantFuckUpThings=$false

######################################################################

######################################################################
# Find the visible name of the interface                             #
######################################################################
function getNICDesc([string] $sCfgKey) {
    $refKey=$LOOKUP_REGKEY+'\'+$sCfgKey+'\Connection'
    $nicName=Get-ItemProperty $refKey -Name 'Name'
    
    return $nicName.Name
}

######################################################################
# Build a list of physical interfaces                                #
######################################################################
function buildIntList([string] $sKey, [boolean] $bOnlyPhy=$True) {
 
 $fillMe=@()
 
 foreach ($subInt in Get-ChildItem -path $sKey | Get-ItemProperty -Name Characteristics,PSChildName,DriverDesc,NetWorkAddress,NetCfgInstanceId) {
    #$subInt.Characteristics
    #$subInt.PSChildName
    #$subInt.DriverDesc
    
    if ($subInt.Characteristics -bAND $NCF_PHYSICAL -or $global:bIdontKnowWhatImDoingAndWantFuckUpThings) {
        # We found a physical device
        
        $nicDesc=getNICDesc $subInt.NetCfgInstanceId
        $iDevID=[int32] $subInt.PSChildName
        $hElement=@{PSPath=$subInt.PSPath;DDesc=$subInt.DriverDesc;MAC=$subInt.NetWorkAddress;VisibleName=$nicDesc;DevID=$iDevID}
        $fillMe += $hElement
    }
 }
 
 return $fillMe
}

######################################################################
# Write out the list of physical interfaces                          #
######################################################################
function dumpArray([System.Array] $dumpMe) {
    if ($dumpMe.Count -lt 1) {
        Write-Host Something went terribly wrong, cannot enumerate NICs
        return
    }
    
    Write-Host "`nHere is the list of the physical NICs on this host`n"
    
    $iCount=0
    foreach ($nic in $dumpMe) {
        if ($nic.MAC.Length -gt 0) {
            $sMac='Spoofed: ' + $nic.MAC
        } else {
            $sMac='Firmware'
        }
        [String] $sLine=$iCount.Tostring() + ') ' + $nic.VisibleName +', [' + $nic.DDesc + '], ' + $sMac
        Write-Host $sLine
        $iCount++
    }
    Write-Host "`nAutomatic cycling for the interface is set to $bCycleInterface`n"
}

######################################################################
# Write help                                                         #
######################################################################
function dumpCommands() {
    Write-Host $CLUTTER_STUFF
    Write-Host 'There are 4 commands:'
    Write-Host 'c <int_num>'
    Write-Host 's <int_num> <spoofed_mac>'
    Write-Host 'cycle'
    Write-Host $QUITCMD
    Write-Host ''
    Write-Host 'Command c clears the spoofed MAC (revert to firmware one)'
    Write-HOst 'Command s spoofs a MAC on the interface'
    Write-HOst 'Command cycle toggles automatic power cycling of the interface after spoofing'
    Write-Host 'Command quit quits the script, slower that ^C'
    Write-Host ''
    Write-HOst 'Examples (yep, keep it simple)'
    Write-HOst 'c 0                  Revert interface 0 to original MAC'
    Write-HOst 's 1 0102030a0b0c     Sets MAC 0102030a0b0c on interface 1'
    Write-Host 'cycle'
    Write-Host 'quit'
    Write-Host ''
}

######################################################################
# Parse the input to figure out if we must do something              #
######################################################################
function chkPowerCycle([int32] $iThisOne) {
 if ($global:bCycleInterface -eq $False) {
  return
 }
 
 Write-Host Finding the device handle...
 $nicDevice=Get-WmiObject -Class win32_networkadapter | Where-Object {$_.DeviceId -eq $iThisOne }
 if ($nicDevice -ne $null) {
    Write-Host Disabling...
    $nicDevice.Disable() | Out-Null
    Write-Host Enabling...
    $nicDevice.Enable() | Out-Null
    Write-Host Windows thinks the MAC for this adapter is $nicDevice.MACAddress
 } else {
    Write-Host Was not able to find WMI handle for $iThisOne
 }
}

######################################################################
# Parse the input to figure out if we must do something              #
######################################################################
function runThisCmd([String] $sCmd, [System.Array] $nicArray) {
    $toks=$sCmd.Trim().Split(' ')
    if ($toks.Count -lt $MIN_CMD_TOKS) {
        Write-Host 'Too few arguments'
        return
    }
    
    if ($toks[0] -ne 'c' -and $toks[0] -ne 's' -and $toks[0] -ne 'cycle') {
        Write-Host 'Invalid command: ' $toks[0]
        dumpCommands
        return
    }
    
    [int32]$iArID=$toks[1]
    if ($iArID -lt 0 -or $iArID -gt $nicArray.count) {
        Write-Host Invalid index $iArId
        return
    }
    
    $keyToModify=$nicArray[$iArId].PSPath
    
    switch ($toks) {
        's' { 
                setMAC $keyToModify $sCmd 
                chkPowerCycle $nicArray[$iArId].DevID
            }
        'c' { 
                clearMAC $keyToModify 
                chkPowerCycle $nicArray[$iArId].DevID
            }
        'cycle' { $global:bCycleInterface= -not $global:bCycleInterface }
    }
}


######################################################################
# Set the new MAC address                                            #
######################################################################
function setMAC([System.Object] $theKey, [string] $cmd) {
    $toks=$cmd.Trim().Split(' ')
    if ($toks.Count -ne 3) {
        Write-Host Invalid parameter count for SET command
        return
    }
    
    [string]$sNewMac=$toks[2]
    if ($sNewMac.Length -ne $GOOD_MAC_LEN) {
        Write-Host Invalid MAC $sNewMac
        return
    }
    
    Write-Host Setting...
    Set-ItemProperty $theKey -Name $VALUE_NAME -Value $sNewMac
    Write-Host New MAC address was set. Disable/Enable the adapter to start using it.
}

######################################################################
# Revert to original MAC                                             #
######################################################################
function clearMAC([System.Object] $theKey) {
    
    Write-Host Restoring...
    Clear-ItemProperty $theKey -Name $VALUE_NAME
    Write-Host Old MAC address was restored. Disable/Enable the adapter to start using it.
}


######################################################################
# Entry point                                                        #
######################################################################

Clear

while ($true) {
    $command=''

    # Figure out which interfaces we have and put it in an array of hash tables
    $intList=buildIntList $REGKEY $true
    # Give some hint
    dumpCommands
    # List the NICs we found
    dumpArray $intList

    # Read commands from the user
    while ($command.Length -lt $CMD_MIN_LEN) {
        $command=read-Host 'Type your command'
    }

    if ($command -ne $QUITCMD) {
        runThisCmd $command $intList
    } else {
        break
    }
} # Main Loop

Write-Out Bye

### DO NOT MODIFY BEYOND THIS LINE ###