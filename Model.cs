namespace WinRGZOSI
{

    // Модель программы, имеет свойства и вычисляет количество взу-ячеек
    partial class Model
    {
        private static Model? hInstance { get; set; }
        public double BufferAmount { get; set; }
        // тк максимальное количество панелек = 14
        public byte MaxSize { get { return 14; } }
        public double BufferSize { get; set; }
        public double FileSize { get; set; }
        public Model Init()
        {
            if (hInstance == null)
                hInstance = new Model();
            return hInstance;
        }
        public double CountOfVZU
        {
            get
            {
                double Count = this.FileSize / this.BufferSize;
                if (Math.Ceiling(Count) <= this.MaxSize)
                    return Math.Ceiling(Count);
                else
                    return 14;
            }
        }
    }
}
