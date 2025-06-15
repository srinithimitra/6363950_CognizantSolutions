package MVCPatternExample;

public class Main {
    public static void main(String[] args) {
        Student student=new Student();
        student.setName("Anjali");
        student.setId("ST123");
        student.setGrade("E");
        StudentView view=new StudentView();
        StudentController controller=new StudentController(student, view);
        controller.updateView();
         controller.setGrade("O");        // Update grade
        controller.updateView(); 
       
    }
    
}
