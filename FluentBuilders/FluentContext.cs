using System;
using System.Collections.Generic;
using System.Linq;

namespace FluentBuilders
{
    /// <summary>
    /// Base class for all fluent contexts. A fluent context should consist of functions that return
    /// the instance of the context at the end.
    /// </summary>
    /// <typeparam name="TModel">The type that this context will build.</typeparam>
    public abstract class FluentContext<TModel> where TModel : new()
    {
        private readonly List<Func<TModel, TModel>> factoryFunctions;

        protected FluentContext()
        {
            this.factoryFunctions = new List<Func<TModel, TModel>>();
        }

        /// <summary>
        /// Adds a builder function to be played when Build is called.
        /// </summary>
        /// <param name="function">The function to build the <typeparam name="{TModel}"></typeparam> class.</param>
        public void AddBuilderFunction(Func<TModel, TModel> function)
        {
            this.factoryFunctions.Add(function);
        }

        /// <summary>
        /// Plays all the builder functions.
        /// </summary>
        /// <returns>The built <typeparam name="{TModel}"></typeparam></returns>
        public TModel Build()
        {
            return this.factoryFunctions.Aggregate(new TModel(), (passenger, func) => func(passenger));
        }
    }
}
