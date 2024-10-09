
using Application.Core;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Persistence;

namespace Application.Activities
{
    public class List
    {
        public class Query : IRequest<Result<List<Activity>>> { }

        public class Handler : IRequestHandler<Query, Result<List<Activity>>>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;

            }
            // Cancelation token is used to cancel the request if the request is no longer needed
            // we don't need them because we don't have long running requests to cancel requests
            public async Task<Result<List<Activity>>> Handle(Query request, CancellationToken cancellationToken)
            {

                var activities = await _context.Activities.ToListAsync();
                return Result<List<Activity>>.Success(activities);

            }
        }
    }
}