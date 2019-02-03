using System;

namespace FluentBuilders
{
    /// <summary>
    /// Base class for a fluent builder. A fluent builder creates the <see cref="FluentContext{TModel}"/> that
    /// allows for fluent object creation.
    /// </summary>
    /// <typeparam name="TModel">The type of class that is created by the builder.</typeparam>
    /// <typeparam name="TContext">The context to use for creation of the classes.</typeparam>
    public abstract class FluentBuilder<TModel, TContext> where TModel : new() where TContext : FluentContext<TModel>, new()
    {
        public static TModel Create(Func<TContext, TContext> factory)
        {
            return factory(new TContext()).Build();
        }
    }
}
