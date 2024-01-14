﻿using Abc.Ext.NUnit.Metadata.Source;
using FuncStore.Conversion.RatioScale;
using FuncStore.Conversion.Tests.Setup.Metadata;
using FuncStore.Conversion.Tests.Setup.Steps;
using Bin = Meas.Units.Prefix.Binary;

namespace FuncStore.Conversion.Tests.Digital;

[TestBy<Multiplication<Bin.In>>]
[TestBy<Exponentiation<Bin.Exponent.In>>]
internal class BinaryPrefixedTests<TStore, TUnit> : ArrangeActAssert<TStore, TUnit>
    where TStore : IFuncStore<TUnit>, new() where TUnit : Enum
{
    [TestOf<Meas.Data.Digital.Calibration>]
    public override void Match<N>(N subject, TUnit subjUnit, N expected, TUnit expUnit, string name, string cat, double? delta) {
        base.Match(subject, subjUnit, expected, expUnit, name, cat, delta);
    }
}
