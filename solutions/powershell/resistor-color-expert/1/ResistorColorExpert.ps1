Function Get-ResistorLabel() {
    <#
    .SYNOPSIS
    Implement a function to get the label of a resistor from its color-coded bands.

    .DESCRIPTION
    Given an array of 1, 4 or 5 colors from a resistor, decode their resistance values and return a string represent the resistor's label.

    .PARAMETER Colors
    The array represent the colors from left to right.

    .EXAMPLE
    Get-ResistorLabel -Colors @("red", "black", "green", "red")
    Return: "2 megaohms ±2%"

    Get-ResistorLabel -Colors @("blue", "blue", "blue", "blue", "blue")
    Return: "666 megaohms ±0.25%"
     #>
    [CmdletBinding()]
    Param(
        [string[]]$Colors
    )
    $values = [ordered]@{
        "black" = 0;
        "brown" = 1;
        "red" = 2;
        "orange" = 3;
        "yellow" = 4;
        "green" = 5;
        "blue" = 6;
        "violet" = 7;
        "grey" = 8;
        "white" = 9;
    }
    $tolerances = [ordered]@{
        "grey" = 0.05;
        "violet" = 0.1;
        "blue" = 0.25;
        "green" = 0.5;
        "brown" = 1;
        "red" = 2;
        "gold" = 5;
        "silver" = 10;
    }

    if($Colors.Length -eq 1) {return "0 ohms"}
    $Result = ""

    for ($i = 0; $i -lt $Colors.Count - 2; $i++) 
    {
        $Result += $values[$Colors[$i]]
    }

    $Result += "0"*$values[$Colors[$Colors.Count - 2]]

    if ($Result.Length -ge 7) {$Result = [string]($Result/1000000) + " mega"} 
    elseif ($Result.Length -ge 4) {$Result = [string]($Result/1000) + " kilo"}
    else {$Result += " "}

    $Result += "ohms ±"
    $Result += $tolerances[$Colors[$Colors.Length - 1]]
    $Result += "%"
    
    return $Result
}