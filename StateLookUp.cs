namespace knightmoves;
using static StateList;

public class StateLookUp{

    public List<string> LookUp(string search){
        return STATES
            .Where(state => state.StartsWith(search))
            .ToList();
    }
}
