using Newtonsoft.Json;

namespace PH.DndNpcGenerator.StatBlockGenerator.Models
{
    public class AbilityModel
    {
        private string _name;
        public string Name { set { _name = value; } get { return _name; } }
        private string _description;
        public string Description { set { _description = value; } get { return _description; } }
        private string _origin;
        public string Origin { set { _origin = value; } get { return _origin; } }
        private List<string> _tags;
        public List<string> Tags {set { _tags = value; } get { return _tags; } }
        public AbilityModel()
        {

        }
        public AbilityModel(StatArrayModel statArray, SettingsModel settings, int points)
        {
            // deserialize Abilities.json using list of Ability objects
            List<Ability> AbilityList;
            Ability SelectedAbility;
            AbilityList = Utilities.Util.LoadJsonData<Ability>("..\\PrestonHicks.DndNpcGenerator.StatBlockGenerator\\Data\\Abilities.json");
            //using (StreamReader reader = new StreamReader("..\\PrestonHicks.DndNpcGenerator.StatBlockGenerator\\Data\\Abilities.json"))
            //{
            //    var AbilitiesJson = reader.ReadToEnd();
            //    AbilityList = JsonConvert.DeserializeObject<List<Ability>>(AbilitiesJson);
            //}

            // create sublist of all valid abilities based on point value and valid tags

            // choose random ability from sublist

            SelectedAbility = AbilityList[0];
            // set properties based on randomly chosen ability
            Name = SelectedAbility.Name;
            Description = SelectedAbility.Description;
            Origin = SelectedAbility.Origin;
            Tags = SelectedAbility.Tags;
        }
        private class Ability
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public string Origin { get; set; }
            public int Cost { get; set; }
            public List<string> Tags { get; set; }
        }
    }
}
//[
//  {
//    "name": "example",
//    "description": "It does a bunch of cool stuff",
//    "origin": "src",
//    "tags": [
//      "fire",
//      "leader",
//      "dwarf"
//    ]
//  }
//]
