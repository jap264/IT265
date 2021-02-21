using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class CanvasUIFunctions : MonoBehaviour
{
    [Header("Title Scene Properties", order = 0)]
    [Space(2f)]
    [Header("Intro Scene Properties", order = 1)]
    public GameObject introImage;
    public GameObject backButton;
    public GameObject nextButton;
    public Color backgroundColor;
    public TMP_Text introText;
    [Header("Tutorial Scene Properties", order = 2)]
    [Space(2f)]
    [Header("Level01 Scene Properties", order = 3)]

    int introSequence;
    Scene currentScene;

    public void SetScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    private void Awake()
    {
        currentScene = SceneManager.GetActiveScene();
        switch (currentScene.name)
        {
            case "00TitleScene":
                break;
            case "01IntroScene":
                InitializeIntro();
                break;
            case "02TutorialScene":
                break;
            case "03Level01Scene":
                break;
        }
    }
    
    void InitializeIntro()
    {
        introText.horizontalAlignment = HorizontalAlignmentOptions.Center;
        introText.text = "Welcome to Cooking Ramen 101!\n\n" + "Learn how to follow recipes by interacting with 3D objects!";
        introImage.SetActive(true);
        backButton.SetActive(false);
    }

    public void IntroSequenceBack()
    {
        introSequence--;
        SetIntroSequence();
    }

    public void IntroSequenceNext()
    {
        introSequence++;
        SetIntroSequence();
    }

    public void SetIntroSequence()
    {
        switch (introSequence)
        {
            case 0:
                InitializeIntro();
                break;
            case 1:
                introImage.SetActive(false);
                backButton.SetActive(true);
                introText.horizontalAlignment = HorizontalAlignmentOptions.Left;
                introText.text = "OVERVIEW\n\n" +
                    "Title: Cooking Ramen 101\n" +
                    "Platform: WebGL\n" +
                    "Subject: Culinary Arts\n" +
                    "Sub Subject: Culinary Skills & Techniques\n" +
                    "Main Focus: Following a recipe\n" +
                    "Learning Level: Grades 1-3";
                break;
            case 2:
                introText.text = "PROPOSED EDTECH SOLUTION\n\n" +
                    "At the targeted learning level, culinary skills are only developed based on the parents that raise their children. Introducing this life skill into school curriculums will provide all students a foundation in this subject and important life skill. At a young age, this software will engage students in a fun way to learn how to follow a recipe. Students will learn how to distinguish between ingredients and recognize the value of decision-making. I am proposing an interactive simulation of putting portions of ingredients into a pot based on a provided recipe where students can see how their decisions affect the outcome of the dish. The game will include a progression feature: starting from low difficulty with simple recipes to higher difficulty levels with more complex recipes.";
                break;
            case 3:
                introText.text = "COMPETING SOFTWARE REVIEW\n\n" +
                    "Cooking Simulator - A fully developed simulation, available on Steam, involving the full kitchen experience. Users can interact with all features within the kitchen, following recipes with advanced cooking mechanics, realistic physics, and perks and skills to unlock.\n\n" +
                    "Can I Eat It? - A PC game for children in preschool where students are required to quickly decide if they think the item on screen is edible. Users can achieve high scores as an incentive to continue learning.\n\n" +
                    "The Boiled Eggs - A PC game with escalating difficulty to appeal to all ages. Players boil egg in different pots simultaneously by tracking the temperature of each pot and adjusting accordingly. This experience is to imitate the occasional need to multitask in the kitchen and how hectic it may become.";
                break;
            case 4:
                introText.text = "COMPETING SOFTWARE SUGGESTED IMPROVEMENTS\n\n" +
                    "Immersion - AR/VR interaction that achieves a higher learning experience for students.\n\n" +
                    "Replayability - More cooking options to engage students into higher levels of decision making.\n\n" +
                    "Accessibility - Being able to play these games on a mobile device would increase audience engagement. Children at a young age are more likely to utilize a phone or tablet device to play games compared to a PC.";
                break;
            case 5:
                introText.text = "STAKEHOLDERS\n\n" +
                    "Teachers\n" +
                    "Parents\n" +
                    "Students\n\n" +
                    "USERS\n\n" +
                    "1st-3rd Elementary School Students";
                break;
            case 6:
                introText.text = "PERSONA\n\n" +
                    "Name: Ben\n" +
                    "Age: 7\n" +
                    "Gender: Male\n" +
                    "Location: City Area USA\n" +
                    "Personal Notes:\n" +
                    "     - Both parents are too busy working to teach him how to make food\n" +
                    "     - Eats prepared lunch from his mom\n" +
                    "Student notes:\n" +
                    "     - Asks about making food in class but only the core subjects are taught at his grade level\n" +
                    "     - Prefers visual learning\n" +
                    "     - Plays cooking games during free time in computer class\n";
                break;
            case 7:
                introText.text = "PERSONA JUSTIFICATION\n\n" +
                    "Ben represents the users of this educational software. I chose this persona because at this age, students begin to develop small interests in school that later turn into passions and hobbies. Ben’s interest is how food is made and could potentially grow into his love for cooking.";
                break;
            case 8:
                introText.text = "PROBLEM SCENARIO\n\n" +
                    "Ben is constantly thinking about food and how it’s made. He is an elementary school student who is interested in cooking due to eating prepared, packed lunches from his mom. However, the teachers cannot stray away from the curriculum of the main four subjects: math, language arts, science, and social studies. He is constantly asking questions about cooking games and expressing how fun it would be to make food. Eventually, the teachers get fed up with his consistent, off-topic questioning about culinary arts and forbid him from asking anymore. This means Ben would be punished if he asked about cooking during lessons on math, science, etc.\n\n" +
                    "Because of the lack of a nurturing environment for his interest, Ben begins to give up his desire to cook and learn how food is made. All the teachers are expressing that it is distracting, not only to him, but also his classmates during school.";
                break;
            case 9:
                introText.text = "ACTIVITY SCENARIO CONTINUED\n\n" +
                    "The next day, Ben’s computer class teacher tells the class that they will be utilizing an educational site with multiple learning programs developed within it for the next week. When Ben receives the link to the educational site, he goes through the list of the varying learning programs. As he is scrolling through, he sees all the courses that he is already learning in school like social studies and language arts. However, there happens to be more than just the core four subjects and Ben stumbles upon culinary arts. The teacher then announces that the students can go through any of the provided learning programs. This excites Ben and he clicks on the culinary arts program to find the first educational software named: Cooking Ramen 101.";
                break;
            case 10:
                nextButton.SetActive(true);
                introText.text = "ACTIVITY SCENARIO\n\n" +
                    "For the past week, Ben finally has a place to learn a topic he is highly interested in which no longer distracts him from the rest of his studies. In fact, it increases his work efficiency and Ben now has a part of the day to look forward to and motivate him. After seeing how Ben has improved in many aspects of his academics, the school realizes they should add this into the school’s curriculum to nurture the many interests of students at a young age.";
                break;
            case 11:
                nextButton.SetActive(false);
                introText.text = "PROBLEM STATEMENT\n\n" +
                    "Ben is constantly distracted by his thoughts of his own personal interest that can potentially become his future career. However, school curriculums only provide the core four subjects in elementary school: math, language arts, science, and social studies. After a small exposure to culinary arts, we notice a huge improvement in Ben’s other academics, as well as his overall happiness in school. An educational software program like Cooking Ramen 101 can be incorporated into elementary school curriculums without taking away from the main four subjects.";
                break;

        }
    }
}
