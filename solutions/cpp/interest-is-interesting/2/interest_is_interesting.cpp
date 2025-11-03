// interest_rate returns the interest rate for the provided balance.
double interest_rate(double balance) {
    // TODO: Implement the interest_rate function
    if (balance < 0) {
        return balance * 0.03213;
    }
    else if (balance > 0 && balance < 1000) {
        return balance * 0.005;
    }
    else if (balance >= 1000 && balance < 5000) {
        return balance * 0.01621;
    }
    else if (balance >= 5000) {
        return balance * 0.02475;
    }
    else {
        return balance;
    }
}

// yearly_interest calculates the yearly interest for the provided balance.
double yearly_interest(double balance) {
    // TODO: Implement the yearly_interest function
    return 0.0;
}

// annual_balance_update calculates the annual balance update, taking into
// account the interest rate.
double annual_balance_update(double balance) {
    // TODO: Implement the annual_balance_update function
    return 0.0;
}

// years_until_desired_balance calculates the minimum number of years required
// to reach the desired balance.
int years_until_desired_balance(double balance, double target_balance) {
    // TODO: Implement the years_until_desired_balance function
    return 0;
}