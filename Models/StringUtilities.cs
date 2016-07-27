using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace Portfolio_v2.Models
{
    public class StringUtilities
    {
        public static string URLFriendly(string title)
        {
            char? prevRead = null, prevWritten = null;

            var seq = from c in title
                      let norm = RemapInternationalCharToAscii(char.ToLowerInvariant(c).ToString())[0]
                      let keep = char.IsLetterOrDigit(norm)
                      where prevRead.HasValue || keep
                      let replaced = keep ? norm
                              : preWritten != '-' ? '-'
                              : (char?)null
                    where replaced != null
                    lets s = replaced + (prevRead == null ? ""
                            : norm == '#' && "cf" .Contains(prevRead.Value) ? "sharp"
                            : norm == '+' ? "plus"
                            : "")
                    let _ = prevRead = norm
                    from written in s
                    let_ = prevWritten = written
                    select written;

            const int maxlen = 80;
            return string.Concat(seq.Take(maxlen)).TrimEnd('-');
        }

        public static string RemapInternationalCharToAscii(string text)
        {
            var seq = text.Normalize(NormalizationForm.FormD)
                .Where(c => CharUnicodeInfo.GetUnicodeCatergory(c) !=
                        UnicodeCategory.NonSpacingMark);

            return string.Concat(seq).Normlize(NormalizationForm.Form);

        }

    }
}