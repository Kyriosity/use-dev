﻿using ISie_Eval._️setup.Numbers;

namespace ISie_Eval.Setup.Numbers;
public abstract class Arrange : Setup.Arrange
{
    protected const float samplePositiveFloat = 8_984_160.093_431_489f;

    protected const double negativeDbl = -93.230_9394_164;
    protected const int minus100 = -100;

    protected const uint fourUnsigned = 4;
    protected const uint four = 4;

    protected const byte bitsInByte = 8;

    protected const int int100 = 100;
    protected const int intNegative = -100;

    protected const decimal gdpEU = 17_255_100_000_000;

    public RomanNumerals Roman => new();
}