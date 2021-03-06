﻿namespace Alpaca.Markets
{
    /// <summary>
    /// Encapsulates list of historical aggregates (bars) from Polygon REST API.
    /// </summary>
    /// <typeparam name="TItem">Type of historical items inside this container.</typeparam>
    public interface IAggHistoricalItems<out TItem> : IHistoricalItems<TItem>
    {
        /// <summary>
        /// Gets type of historical aggregates (bars) in this container.
        /// </summary>
        AggregationType AggregationType { get; }
    }
}