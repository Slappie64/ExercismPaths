#include <string>

namespace log_line {

    public string message(string inputlog) {
        return inputlog.substr(inputlog.find(":"));
    }

} // namespace log_line
