using static State_1.Program;


namespace State_1
{
    public interface IState
    {
        void DoAction(Context context);
    }
}