namespace CodelyTv.Mooc.CoursesCounter.Application.Find
{
    using System.Threading.Tasks;
    using CodelyTv.Shared.Domain.Bus.Query;

    public class FindCoursesCounterQueryHandler : IQueryHandler<FindCoursesCounterQuery, CoursesCounterResponse>
    {
        private readonly CoursesCounterFinder _finder;

        public FindCoursesCounterQueryHandler(CoursesCounterFinder finder)
        {
            _finder = finder;
        }

        public async Task<CoursesCounterResponse> Handle(FindCoursesCounterQuery query)
        {
            return await _finder.Find();
        }
    }
}