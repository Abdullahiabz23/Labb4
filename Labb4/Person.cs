using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using Labb4;

public class Person
{
    public Gender Gender { get; set; }
    public Hair Hair { get; set; }

    public DateTime Birthdate { get; set; }

    public string EyeColor { get; set; }

    public override string ToString()
    {
        return $"Kön: {Gender}, " +
            $"Hårlängd: {Hair.HairLength} cm, " +
            $"Hårfärg: {Hair.HairColor}, " +
            $"Födelsedag: {Birthdate.ToShortDateString()}, " +
            $"Ögonfärg: {EyeColor}";
    }
}