namespace knightmoves;
using static StateList;

public class StateLookUp{

    public object LookUp(string search){
        var matches = STATES
            .Where(state => state.StartsWith(search))
            .ToList();

        return matches;
    }
}