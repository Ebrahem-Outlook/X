﻿using MediatR;

namespace X.Application.Core.Masseges;

public interface IQueryHandler<in TQuery> : IRequestHandler<TQuery>
    where TQuery : IQuery
{
}

public interface IQueryHandler<in TQuery, TResult> : IRequestHandler<TQuery, TResult>
    where TQuery : IQuery<TResult>
    where TResult : notnull
{
}
