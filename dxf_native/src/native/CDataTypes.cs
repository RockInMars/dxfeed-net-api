﻿#region License
// Copyright (C) 2010-2016 Devexperts LLC
//
// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
// If a copy of the MPL was not distributed with this file, You can obtain one at
// http://mozilla.org/MPL/2.0/.
#endregion

using System;
using System.Runtime.InteropServices;
using com.dxfeed.api.data;
using com.dxfeed.api.events;

namespace com.dxfeed.native.api
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    internal unsafe struct DxOrder
    {
        internal int count;
        internal EventFlag event_flags;
        internal char exchange_code;
        internal long index;
        internal int level;
        internal Side side;
        internal double price;
        internal int scope;
        internal int sequence;
        internal long size;
        internal fixed char source[5]; //string
        internal long time;
        internal long time_sequence;
        internal IntPtr market_maker; //string
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    internal unsafe struct DxSpreadOrder
    {
        internal int count;
        internal EventFlag event_flags;
        internal char exchange_code;
        internal long index;
        internal int level;
        internal Side side;
        internal double price;
        internal int scope;
        internal int sequence;
        internal long size;
        internal fixed char source[5]; //string
        internal long time;
        internal long time_sequence;
        internal IntPtr spread_symbol; //string
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    internal struct DxTrade
    {
        internal long time;
        internal char exchange_code;
        internal double price;
        internal long size;
        internal long tick;
        internal double change;
        internal double day_volume;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    internal struct DxQuote
    {
        internal long bid_time;
        internal char bid_exchange_code;
        internal double bid_price;
        internal long bid_size;
        internal long ask_time;
        internal char ask_exchange_code;
        internal double ask_price;
        internal long ask_size;

        public override string ToString()
        {
            return string.Format("BidTime: {0}, BidExchangeCode: {1}, BidPrice: {2}, BidSize: {3}, AskTime: {4}, AskExchangeCode: {5}, AskPrice: {6}, AskSize: {7}", bid_time, bid_exchange_code, bid_price, bid_size, ask_time, ask_exchange_code, ask_price, ask_size);
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct DxSummary
    {
        internal int day_id;
        internal double day_open_price;
        internal double day_high_price;
        internal double day_low_price;
        internal double day_close_price;
        internal int prev_day_id;
        internal double prev_day_close_price;
        internal long open_interest;
        internal long flags;
        internal char exchange_code;
        internal PriceType day_close_price_type;
        internal PriceType prev_day_close_price_type;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    internal struct DxProfile
    {
        internal double beta;
        internal double eps;
        internal long div_freq;
        internal double exd_div_amount;
        internal int exd_div_date;
        internal double _52_high_price;
        internal double _52_low_price;
        internal double shares;
        internal IntPtr description;
        internal long flags;
        internal IntPtr status_reason;
        internal long halt_start_time;
        internal long halt_end_time;
        internal double high_limit_price;
        internal double low_limit_price;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    internal struct DxMarketMaker
    {
        internal char mm_exchange;
        internal int mm_id;
        internal double mmbid_price;
        internal int mmbid_size;
        internal double mmask_price;
        internal int mmask_size;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    internal struct DxTimeAndSale
    {
        internal long event_id;
        internal long time;
        internal int sequence;
        internal char exchange_code;
        internal double price;
        internal long size;
        internal double bid_price;
        internal double ask_price;
        internal IntPtr exchange_sale_conditions;
        internal int flags;
        internal EventFlag event_flags;
        internal long index;
        internal Side side;
        internal bool is_cancel;
        internal bool is_correction;
        internal bool is_trade;
        internal bool is_new;
        internal bool is_spread_leg;
        internal bool is_valid_tick;
        internal TimeAndSaleType type;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    internal struct DxCandle
    {
        internal long time;
        internal int sequence;
        internal double count;
        internal double open;
        internal double high;
        internal double low;
        internal double close;
        internal double volume;
        internal double vwap;
        internal double bid_volume;
        internal double ask_volume;
        internal long index;
        internal long open_interest;
        internal double imp_volatility;
        internal EventFlag event_flags;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    internal struct DxTradeEth
    {
        internal long time;
        internal int flags;
        internal char exchange_code;
        internal double price;
        internal long size;
        internal double eth_volume;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    internal struct DxGreeks
    {
        internal long time;
        internal int sequence;
        internal double greeks_price;
        internal double volatility;
        internal double delta;
        internal double gamma;
        internal double theta;
        internal double rho;
        internal double vega;
        internal long index;
        internal EventFlag event_flags;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    internal struct DxTheoPrice
    {
        internal long theo_time;
        internal double theo_price;
        internal double theo_underlying_price;
        internal double theo_delta;
        internal double theo_gamma;
        internal double theo_dividend;
        internal double theo_interest;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    internal struct DxUnderlying
    {
        internal double volatility;
        internal double front_volatility;
        internal double back_volatility;
        internal double put_call_ratio;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    internal struct DxSeries
    {
        internal int expiration;
        internal int sequence;
        internal double volatility;
        internal double put_call_ratio;
        internal double forward_price;
        internal double dividend;
        internal double interest;
        internal long index;
        internal EventFlag event_flags;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    internal unsafe struct DxConfiguration
    {
        internal IntPtr string_object; //string
    }


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    internal struct DxEventParams
    {
        internal EventFlag flags;
        internal ulong time_int_field;
        internal ulong snapshot_key;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    internal struct DxSnapshotData
    {
        internal EventType event_type;
        internal IntPtr symbol;

        internal int records_count;
        internal IntPtr records;
    }
}