using System.ComponentModel;

namespace NygarnDemo.Enums
{
    public enum KnittingTension
    {
        [Description("10x10cm")]
        KnittingTension10mX10cm = 0,

        [Description("21x10cm")]
        knittingTension21mX10cm = 1,

        [Description("25x10cm")]
        knittingTension25mX10cm = 2,

        [Description("30x10cm")]
        knittingTension30mX10cm = 3

    }
}
