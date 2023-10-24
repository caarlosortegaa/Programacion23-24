
namespace Dolphin
{
    public class CharacterUtils
    {
        List<Character> list = new List<Character>();
        string? name;

        public static bool Contains(List<Character> list, string name)
        {
            if(list == null)
                return false;
            for(int i = 0; i < list.Count; i++)
            {
                if(list[i].name == name)
                    return true;
            }
            return false;
        }
        public static Character Objeto( List<Character> list , string name)
        {
            for(int i = 0; i < list.Count; i++)
            {
                if (list[i].name == name)
                    return list[i];
            }
            return null;
        }
        public static bool ContainsDuplicado(List<Character> list)
        {
            for(var i = 0; i < list.Count; i++)
            {
                for(int j = 1; j < list.Count; j++)
                {
                    if (list[i] == list[j])
                        return true;
                }
            }
            return false;
        }
    }
}
