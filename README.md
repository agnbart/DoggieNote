# DoggieNote

**- Encje -**

Competition - CompetitionId, Name, Place, List<Course>
  
Course - CoursId, Name, CompetitionId

  
**- Relacje -**
  
1 do wiele - 1 Competition wiele Course

**- Oczekiwania -**
  
Przy wyświetlaniu [Competition] -> [Details], wyświetlane wszystkie przypisane Courses.
  
Przy wprowadzaniu Course możliwość wyboru Competition z rozwijanej listy. (Listę można rozwinąć. Pojawiają się na niej Competition, ale nie można tego zapisać.)

  
**- Problem -**
  
Przy wyborze [Competition WITH relations] -> [Details] - pojawia się błąd: "Object reference not set to an instance of an object" w [Views]/[CompetitionControllerWithRelations]/[Details.cshtml] linijka 28

 
