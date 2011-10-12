﻿using System;
using Manifold.DependencyInjection;

namespace Manifold.Configuration.Operations
{
    public interface IOperation
    {
        Func<IResolveTypes, object, object> GetExecutor();
    }

    public interface IRoutedOperation : IOperation
    {
        Func<IResolveTypes, object, bool> GetDecider();
    }
}
