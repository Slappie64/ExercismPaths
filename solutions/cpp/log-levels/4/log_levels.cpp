#include <string>

namespace log_line {

    std::string message(std::string inputlog) {
        return inputlog.substr(inputlog.find(":"));
    }

    std::string log_level(std::string inputlog) {
        return inputlog;
    }

    std::string reformat(std::string inputlog) {
        return inputlog;
    }

} // namespace log_line
