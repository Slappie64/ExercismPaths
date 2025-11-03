#include <string>

namespace log_line {

    string message(string inputlog) {
        return inputlog.substr(inputlog.find(":"));
    }

    string log_level(string inputlog) {
        return inputlog;
    }

    string reformat(string inputlog) {
        return inputlog;
    }

} // namespace log_line
