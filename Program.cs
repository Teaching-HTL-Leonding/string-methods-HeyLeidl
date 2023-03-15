bool Contains(string input, char searchchar)
{
    for (int i = 0; i < input.Length; i++)
    {
        if(input[i] == searchchar)
        {
            return true;
        }
    }
    return false;
}


int IndexOf(string Search, char target )
{
    for (int i = 0; i < Search.Length; i++)
    {
        if(target == Search[i])
        {
            return i;
        }
    }
    return  -1;
}
int MyLastIndexOf(string str, char ch)
{
    if (str == null) throw new ArgumentNullException(nameof(str));
    
    for (int i = str.Length - 1; i >= 0; i--)
    {
        if (str[i] == ch) return i;
    }
    
    return -1;
}

static string MyTrimStart(string str, char ch)
{
    if (str == null) throw new ArgumentNullException(nameof(str));
    
    int startIndex = 0;
    
    while (startIndex < str.Length && str[startIndex] == ch)
    {
        startIndex++;
    }
    
    return str.Substring(startIndex);
}

static string MyTrimEnd(string str, char ch)
{
    if (str == null) throw new ArgumentNullException(nameof(str));
    
    int endIndex = str.Length - 1;
    
    while (endIndex >= 0 && str[endIndex] == ch)
    {
        endIndex--;
    }
    
    return str.Substring(0, endIndex + 1);
}

static string MyTrim(string str, char ch)
{
    return MyTrimStart(MyTrimEnd(str, ch), ch);
}

static string MySubString(string str, int startIndex, int length)
{
    if (str == null) throw new ArgumentNullException(nameof(str));
    if (startIndex < 0 || startIndex >= str.Length) throw new ArgumentOutOfRangeException(nameof(startIndex));
    if (length < 0) throw new ArgumentOutOfRangeException(nameof(length));
    
    int endIndex = startIndex + length - 1;
    if (endIndex >= str.Length) endIndex = str.Length - 1;
    
    return str.Substring(startIndex, endIndex - startIndex + 1);
}
static string MyRemove(string str, int startIndex, int count)
{
    if (str == null) throw new ArgumentNullException(nameof(str));
    if (startIndex < 0 || startIndex >= str.Length) throw new ArgumentOutOfRangeException(nameof(startIndex));
    if (count < 0) throw new ArgumentOutOfRangeException(nameof(count));
    
    if (startIndex + count >= str.Length) 
    {
        return str.Substring(0, startIndex);
    }
    else 
    {
        return str.Substring(0, startIndex) + str.Substring(startIndex + count);
    }
}
