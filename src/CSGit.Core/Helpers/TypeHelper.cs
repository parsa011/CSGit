namespace CSGit.Core.Helpers;

public class TypeHelper
{
    public static List<string> GetFieldsName(Type tp, Func<System.Reflection.FieldInfo, bool>? predicate = null)
    {
        var res = new List<string>();
        var fields = tp.GetFields().AsQueryable();
        if (predicate != null)
            fields = fields.Where(predicate).AsQueryable(); ;
        foreach (var f in fields)
        {
            res.Add(f.Name);
        }
        return res;
    }
}