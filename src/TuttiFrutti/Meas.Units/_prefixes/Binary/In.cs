using Meas.Units.Metadata;

namespace Meas.Units.Prefix.Binary;

[Factored]
public enum In : ulong
{
    Undefined = 0,

    kibi = 1_024,
    mebi = 1_048_576,
    gibi = 1_073_741_824,
    tebi = 1_099_511_627_776,
    pebi = 1_125_899_906_842_624,
    exbi = 115_292_150_460_684_6976,
    //zebi = 1_180_591_620_717_411_303_424,
    //yobi = 1_208_925_819_614_629_174_706_176
}
