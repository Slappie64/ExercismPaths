Function Get-ColorCode() {
    <#
    .SYNOPSIS
    Translate a color to its corresponding color code.

    .DESCRIPTION
    Given a color, return its corresponding color code.

    .PARAMETER Color
    The color to translate to its corresponding color code.

    .EXAMPLE
    Get-ColorCode -Color "black"
    #>
    [CmdletBinding()]
    Param(
        [string]$Color
    )
    
    Switch ($Color)
    {
        "black" {return 0}
        "brown" {return 1}
        "red" {return 2}
        "orange" {return 3}
        "yellow" {return 4}
        "green" {return 5}
        "blue" {return 6}
        "violet" {return 7}
        "grey" {return 8}
        "white" {return 9}
    }
}

Function Get-Colors() {
    <#
    .SYNOPSIS
    Return the list of all colors.

    .DESCRIPTION
    Return the list of all colors.

    .EXAMPLE
    Get-Colors
    #>
    
    return ("black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white")
}
