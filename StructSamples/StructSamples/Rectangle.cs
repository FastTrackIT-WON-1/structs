namespace StructSamples
{
    public struct Rectangle : IObjectWithArea
	{
		public Rectangle(int width, int height)
		{
			this.Width = width;
			this.Height = height;
		}

		public int Width
		{
			get;
			set;
		}

		public int Height
		{
			get;
			set;
		}

		public double GetArea()
		{
			return this.Width * this.Height;
		}
	}
}
