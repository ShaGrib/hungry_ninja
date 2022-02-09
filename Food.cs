class Food
{
    public string Name;
    public int Calories;
    public bool IsSpicy; 
    public bool IsSweet; 

    public Food(string nm, int cal, bool spice, bool swe)
    {
        Name = nm;
        Calories = cal;
        IsSpicy = spice;
        IsSweet = swe;
    }
}