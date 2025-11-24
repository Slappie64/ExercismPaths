namespace hellmath {

enum class AccountStatus {
    troll,
    guest,
    user,
    mod
};

enum class Action {
    read,
    write,
    remove
};
    
bool display_post(AccountStatus poster, AccountStatus viewer) {
    if (poster == AccountStatus::troll && viewer != AccountStatus::troll) {
        return false;
    }
    else {
        return true;
    }
}

bool permission_check(Action action, AccountStatus accountStatus) {
    switch (accountStatus) {
      case AccountStatus::guest:
        return action == Action::read;
      case AccountStatus::user:
        return action == Action::read || action == Action::write;
      case AccountStatus::troll:
        return action == Action::read || action == Action::write;
      case AccountStatus::mod:
        return action == Action::read || action == Action::write ||
               action == Action::remove;
      default:
        return false;
    }
}
    
bool valid_player_combination(AccountStatus playerOne, AccountStatus playerTwo) {
    if (playerOne == AccountStatus::guest || playerTwo == AccountStatus:: guest) {
        return false;
    }
    else if (playerOne == AccountStatus::troll && playerTwo == AccountStatus::troll) {
        return true;
    }
    else if (playerOne == AccountStatus::troll || playerTwo == AccountStatus::troll) {
        return false;
    }
    else {
        return true;
    }
}
    
bool has_priority(AccountStatus playerOne, AccountStatus playerTwo) {
    return playerOne > playerTwo;
}
    
}  // namespace hellmath
