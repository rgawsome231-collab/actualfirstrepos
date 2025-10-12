using System;

public class Octopus
{
    //Octopus exists now
    public string Name { get; }
    public Octopus Mate { get; private set; }

    //constructor creates Octopuses and sets thier names.
    public Octopus(string name)
    {
        Name = name;
    }

    //declares the two Octopuses as partners.
    public void Mate(Octopus partner)
    {
        Mate = partner;
        partner.Mate = this;
    }
}

class Program
{
    static void Main() //used to assign Octopuses variables with names for later output.
    {
        Octopus Heidi = new Octopus("Heidi"); //"Heidi" A day octopus (Octopus cyanea) studied by marine biologist David Scheel in Anchorage, Alaska.
                                              //Heidi lived in Scheel’s home aquarium, interacted with the family (including his daughter), watched TV, played with toys, etc.
                                              //The work was featured in the documentary Octopus: Making Contact (also titled The Octopus in My House) to explore octopus behavior, social aspects, and intelligence.
                                              //https://www.minnesotaalumni.org/stories/dreaming-with-an-octopus

        Octopus Inky = new Octopus("Inky"); //A common New Zealand octopus at the National Aquarium of New Zealand in Napier. 
                                            //Inky became famous for escaping: he crawled out of his tank, across the floor, and down a drainpipe that led back to the ocean.
                                            //This escape was widely reported in the media and used to highlight octopus intelligence and escape capacities.

        hon.Mate(Inky); //this declares that they are mates.

        Console.WriteLine($"{hon.Name}'s mate is {hon.Mate.Name}"); // these two codes print their names, the output of the file.
        Console.WriteLine($"{Inky.Name}'s mate is {Inky.Mate.Name}");
    }
}