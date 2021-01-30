namespace Implementation6
{
    public abstract class Сlothing : IFabric
    {
        protected int Length { get; set; }
        protected int Weight { get; set; }
        protected int Height { get; set; }

        public string Texture { get; set; }

        public int GetLength()
        {
            return Length;
        }

        public int GetWeight()
        {
            return Weight;
        }
        public int GetHeight()
        {
            return Height;
        }

        public string GetTexture()
        {
            return Texture;
        }

        public abstract void CutToChangeLength(int length);

        public abstract void CutToChangeHeigth(int length);

        public abstract void CutToChangeWeight(int weight);

        public abstract void ChangeTexture(string texture);
    }
}