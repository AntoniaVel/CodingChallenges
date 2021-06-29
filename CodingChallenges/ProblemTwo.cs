using System;
using System.Text.RegularExpressions;

namespace CodingChallenges
{
    public class ProblemTwo
    {
        public string PostCode { get; set; }

        private string OutwardCode => FormattedPostCode[0..^3];

        private string OutwardLetter => OutwardCode.Substring(0, OutwardCodeIndex);

        private string OutwardNumber => OutwardCode.Substring(OutwardCodeIndex);

        private string InwardCode => FormattedPostCode[^3..];

        private string FormattedPostCode => PostCode.ToUpper().Replace(" ", string.Empty);

        private int OutwardCodeIndex => new Regex(@"\d+").Match(OutwardCode).Index;

        public string PostCodeParser()
        {
            return $"# POSTCODE: {FormattedPostCode}\n\tOUTWARD CODE: {OutwardCode}\n\t\tOUTWARD LETTER: {OutwardLetter}\n\t\tOUTWARD NUMBER: {OutwardNumber}\n\tINWARD CODE: {InwardCode}\n";
        }
    }
}
