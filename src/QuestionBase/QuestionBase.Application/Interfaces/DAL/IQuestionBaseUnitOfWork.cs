namespace QuestionBase.Application.Interfaces.DAL
{
    public interface IQuestionBaseUnitOfWork
    {
        ITeamRepository TeamRepository { get; set; }
        void Commit();
    }
}
