
namespace FetchImages
{
    public class OperationProgress
    {
        public virtual int Total { get; }
        public virtual int Completed { get; }
        public object UserState { get; }
        public virtual float Progress => this.Completed == 0 || this.Total == 0 ? 0 : (this.Completed * 100 / (float)this.Total);
        public OperationProgress(int total, int completed, object userState)
        {
            this.Total = total;
            this.Completed = completed;
            this.UserState = userState;
        }
        public OperationProgress(int total, int completed) : this(total, completed, null) { }
    }
}
