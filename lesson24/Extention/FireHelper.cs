using lesson24.Enum;

namespace lesson24.Extention
{
    internal static class FireHelper<T>
    {
        private static readonly string[] _paths = new string[]
        {
            @"C:\Users\student\Desktop\Hotels\Hotels.txt",
            @"C:\Users\student\Desktop\Hotels\Rooms.txt",
            @"C:\Users\student\Desktop\Hotels\Users.txt",
        };

        public static void WriteInFile(
            FILE_TYPES filetype, T entity, bool append = true)
        {
            using (StreamWriter writer = new StreamWriter(
                _paths[Convert.ToInt32(filetype)], append: append))
            {
                writer.WriteLine(entity);
            }

        }

        public static void WriteInFile(
        FILE_TYPES filetype, List<T> values, bool append = true)
        {
            using (StreamWriter writer = new StreamWriter(
                _paths[Convert.ToInt32(filetype)], append: append))
            {
                foreach (T entity in values)
                {
                    writer.WriteLine(entity);
                }
            }

        }
    }
}
