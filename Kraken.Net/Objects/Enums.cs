﻿using Kraken.Net.Converters;
using Newtonsoft.Json;

namespace Kraken.Net.Objects
{
    /// <summary>
    /// The time interval of kline data
    /// </summary>
    public enum KlineInterval
    {
        /// <summary>
        /// 1m
        /// </summary>
        OneMinute,
        /// <summary>
        /// 5m
        /// </summary>
        FiveMinutes,
        /// <summary>
        /// 15m
        /// </summary>
        FifteenMinutes,
        /// <summary>
        /// 30m
        /// </summary>
        ThirtyMinutes,
        /// <summary>
        /// 1h
        /// </summary>
        OneHour,
        /// <summary>
        /// 4h
        /// </summary>
        FourHour,
        /// <summary>
        /// 1d
        /// </summary>
        OneDay,
        /// <summary>
        /// 1w
        /// </summary>
        OneWeek,
        /// <summary>
        /// 15d
        /// </summary>
        FifteenDays
    }

    /// <summary>
    /// Side of an order
    /// </summary>
    [JsonConverter(typeof(OrderSideConverter))]
    public enum OrderSide
    {
        /// <summary>
        /// Buy
        /// </summary>
        Buy,
        /// <summary>
        /// Sell
        /// </summary>
        Sell
    }

    /// <summary>
    /// Order type, limited to market or limit
    /// </summary>
    [JsonConverter(typeof(OrderTypeMinimalConverter))]
    public enum OrderTypeMinimal
    {
        /// <summary>
        /// Limit order
        /// </summary>
        Limit,
        /// <summary>
        /// Market order
        /// </summary>
        Market
    }

    /// <summary>
    /// Order type
    /// </summary>
    [JsonConverter(typeof(OrderTypeConverter))]
    public enum OrderType
    {
        /// <summary>
        /// Limit order
        /// </summary>
        Limit,
        /// <summary>
        /// Market order
        /// </summary>
        Market,
        /// <summary>
        /// Stop market order
        /// </summary>
        StopMarket,
        /// <summary>
        /// Stop loss order
        /// </summary>
        StopLoss,
        /// <summary>
        /// Take profit order
        /// </summary>
        TakeProfit,
        /// <summary>
        /// Stop loss profit order
        /// </summary>
        StopLossProfit,
        /// <summary>
        /// Stop loss profit limit order
        /// </summary>
        StopLossProfitLimit,
        /// <summary>
        /// Stop loss limit order
        /// </summary>
        StopLossLimit,
        /// <summary>
        /// Take profit limit order
        /// </summary>
        TakeProfitLimit,
        /// <summary>
        /// Trailing stop order
        /// </summary>
        TrailingStop,
        /// <summary>
        /// Trailing stop limit order
        /// </summary>
        TrailingStopLimit,
        /// <summary>
        /// Stop loss and limit order
        /// </summary>
        StopLossAndLimit,
        /// <summary>
        /// Settle position
        /// </summary>
        SettlePosition
    }

    /// <summary>
    /// Status of an order
    /// </summary>
    [JsonConverter(typeof(OrderStatusConverter))]
    public enum OrderStatus
    {
        /// <summary>
        /// Pending
        /// </summary>
        Pending,
        /// <summary>
        /// Active, not (fully) filled
        /// </summary>
        Open,
        /// <summary>
        /// Fully filled
        /// </summary>
        Closed,
        /// <summary>
        /// Canceled
        /// </summary>
        Canceled,
        /// <summary>
        /// Expired
        /// </summary>
        Expired
    }

    /// <summary>
    /// The type of a ledger entry
    /// </summary>
    [JsonConverter(typeof(LedgerEntryTypeConverter))]
    public enum LedgerEntryType
    {
        /// <summary>
        /// Deposit
        /// </summary>
        Deposit,
        /// <summary>
        /// Withdrawal
        /// </summary>
        Withdrawal,
        /// <summary>
        /// Trade change
        /// </summary>
        Trade,
        /// <summary>
        /// Margin
        /// </summary>
        Margin
    }
}