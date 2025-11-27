#include <string>
#include <vector>

namespace election {

// The election result struct is already created for you:

    struct ElectionResult {
        // Name of the candidate
        std::string name{};
        // Number of votes the candidate has
        int votes{};
    };
    
    int vote_count(ElectionResult& electionResult )
    {
        return electionResult.votes;
    }

    void increment_vote_count(ElectionResult& electionResult, int votes)
    {
        electionResult.votes += votes;
    }

    ElectionResult& determine_result(std::vector<ElectionResult>& final_count)
    {
        int max=0;
        int index=0;
        for (int i=0; i<final_count.size(); i++){
            if (final_count[i].votes > max){
                max = final_count[i].votes;
                index=i;
            }
        }
        final_count[index].name = "President " + final_count[index].name;
        return final_count[index];
    }
}  // namespace election
