﻿namespace ConsoleAppDevRisk
{
    public interface ITrade
    {
        double Value { get; }
        string ClientSector { get; }
        DateTime NextPaymentDate { get; }
    }
}