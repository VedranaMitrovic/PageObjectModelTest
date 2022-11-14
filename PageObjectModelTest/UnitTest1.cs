using PageObjectModelTest.Helper;
using PageObjectModelTest.Page;

namespace PageObjectModelTest
{
    public class Tests:Base
    {

        PracticeForm form;

        [Test]
        public void Test1()
        {
            form = new PracticeForm();
            form.EnterFirstName("Vedrana");
            form.EnterLastName("Mitrovic");
            form.EnterEmail("vedrana@mail.com");
            form.SelectGender();
            form.EnterMobile("063123456");
            form.EnterSubject("Maths");
            form.SelectHobbies();
            form.PressButton();
        }
    }
}