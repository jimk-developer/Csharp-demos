namespace Demo6
{
    // A Wall object knows its size and how much paint it needs.
    // The constructor does the math; the properties are read-only.
    public class Wall
    {
        private string _name;
        private int _width;
        private int _height;
        private int _area;
        private int _quarts;

        public Wall(string name, int width, int height)
        {
            _name = name;
            _width = width;
            _height = height;

            // Calculate the area in square feet
            _area = _width * _height;

            // 1 quart covers 100 sq ft, plus 1 more quart for any leftover
            _quarts = _area / 100;
            if (_area % 100 > 0)
            {
                _quarts++;
            }
        }

        public string Display()
        {
            return $"{_name} ({_width}x{_height}) needs {_quarts} quarts";
        }

        // ---------- Read-only properties (get only) ----------

        public string Name
        {
            get { return _name; }
        }

        public int Width
        {
            get { return _width; }
        }

        public int Height
        {
            get { return _height; }
        }

        public int Area
        {
            get { return _area; }
        }

        public int Quarts
        {
            get { return _quarts; }
        }
    }
}
