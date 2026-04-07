namespace knightmoves;
using static StateList;

public class StateLookUp{

    public object LookUp(string search){
        return STATES
            .Where(state => state.StartsWith(search));
    }
}
