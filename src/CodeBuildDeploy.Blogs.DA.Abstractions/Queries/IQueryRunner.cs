namespace CodeBuildDeploy.Blogs.DA.Queries
{
    public interface IQueryRunner<TReturn>
    {
        Task<TReturn> ExecuteAsync(CancellationToken token);
    }

    public interface IQueryRunner<in TParam, TReturn>
    {
        Task<TReturn> ExecuteAsync(TParam query, CancellationToken token);
    }
}