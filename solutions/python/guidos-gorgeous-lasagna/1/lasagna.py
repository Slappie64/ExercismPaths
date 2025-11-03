"""Functions used in preparing Guido's gorgeous lasagna.

Learn about Guido, the creator of the Python language:
https://en.wikipedia.org/wiki/Guido_van_Rossum

This is a module docstring, used to describe the functionality
of a module and its functions and/or classes.
"""


EXPECTED_BAKE_TIME = 40


def bake_time_remaining(elapsed_bake_time):
    """ Calculate remaining bake time.

    : param elapsed_bake_time: int - Elapsed cooking time
    : return int - The remaining time left in the oven.

    This function takes the EXPECTED_BAKE_TIME const and takes away the elapsed_bake_time
    """
    return EXPECTED_BAKE_TIME - elapsed_bake_time

def preparation_time_in_minutes(number_of_layers):
    """ Calculate preparation time in minutes.

    : param number_of_layers: int - Number of layers for the lasagna
    : return: int - Number of layers multiplied by 2 for minutes

    This function converts the number of layers into prep time in minutes by multiplying by 2.
    """
    return number_of_layers * 2

def elapsed_time_in_minutes(number_of_layers, elapsed_bake_time):
    """ Calculate total elapsed time in minutes.

    : param number_of_layers: int - Number of layers for the lasagna
    : param elapsed_bake_time: int - Elapsed cooking time
    : return: int - Total preparation time in minutes plus elapsed bake time.

    This function uses preparation_time_in_minutes to convert number_of_layers into minutes
    then adds the elapsed bake time to calculate total time in minutes
    """
    return preparation_time_in_minutes(number_of_layers) + elapsed_bake_time