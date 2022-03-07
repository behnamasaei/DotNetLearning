Regex Syntax

There are many basic syntaxes like Quantifiers, Special Characters, Character Classes, Grouping &amp; Alternatives are used for regular expressions.

**Quantifiers:**

| Sub-expression(Greedy) | Sub-expression(Lazy) | Matches |
| --- | --- | --- |
| \* | \*? | Used to match the preceding character zero or more times. |
| --- | --- | --- |
| + | +? | Used to match the preceding character one or more times. |
| ? | ?? | Used to match the preceding character zero or one time. |
| {n} | {n}? | Used to match the preceding character exactly n times. |
| {n, } | {n, }? | Used to match the preceding character at least n times. |
| {n, m} | {n, m}? | Used to match the preceding character from n to m times. |

**Special Characters**

| Sub-expression | Matches |
| --- | --- |
| ^ | Word after this element matches at the beginning of the string or line. |
| --- | --- |
| $ | Word before this element matches at the end of the line or string. |
| .(Dot) | Matches any character only once expect \n(new line). |
| \d | It is use to match the digit character. |
| \D | It is use to match the non-digit character. |
| \w | It is use to match any alphanumeric and underscore character. |
| \W | It is use to match the any non-word character. |
| \s | It is use to match the white-space characters. |
| \S | It is use to match the non white-space characters. |
| \n | It is use to match a newline character. |

**Character Classes**

| Sub-expression | Matches |
| --- | --- |
| [] | It is used to match the range of character |
| --- | --- |
| [a-z] | It is used to match any character in the range of a-z. |
| [^a-z] | It is used to match any character not in the range of a-z. |
| \ | It is used to match Escaped special character. |

**Grouping and Alternatives**

| Sub-expression | Matches |
| --- | --- |
| () | It is used for group expression |
| --- | --- |
| (a|b) | | Operator is used for alternative either a or b. |
| (?(exp) yes|no) | If expression is matched it gives yes otherwise it gives no. |
