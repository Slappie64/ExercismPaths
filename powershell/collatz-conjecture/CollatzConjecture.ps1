Function Invoke-CollatzConjecture() {
    <#
    .SYNOPSIS
    Calculate the number of steps to reach 1 using the Collatz conjecture.

    .DESCRIPTION
    Take any positive integer n. If n is even, divide n by 2 to get n / 2. If n is odd, multiply n by 3 and add 1 to get 3n + 1. Repeat the process indefinitely. The conjecture states that no matter which number you start with, you will always reach 1 eventually.

    .PARAMETER Number
    The number to perform the Collatz Conjecture function on.

    .EXAMPLE
    Invoke-CollatzConjecture -Number 12
    #>
    [CmdletBinding()]
    Param(
        [Int64]$Number
    )

    $Count = 0
    if($Number -le 0) { Throw "*error: Only positive numbers are allowed*" }

    while($Number -gt 1)
    {
        if ($Number % 2 -eq 0) {$Number /= 2}
        else {$Number = ($Number * 3) + 1}
        $Count ++
    }
    return $Count
}
