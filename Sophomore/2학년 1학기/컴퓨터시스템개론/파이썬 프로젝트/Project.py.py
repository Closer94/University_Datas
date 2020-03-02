class Student():
    def __init__(self, list):
        self._total = 0
        self._avg = 0.0
        self._num = 0
        self._name = " "
        self._kor = 0
        self._eng = 0
        self._math = 0
        self._total = 0
        self._avg = 0.0
        self._list = list

    def _calculate_total(self):
        self._total = int(self.kor()) + int(self.eng()) + int(self.math())
        self._list.append(self._total)
    
    def _calculate_avg(self):
        self._avg = float((int(self.kor()) + int(self.eng()) + int(self.math()))/3.0)
        self._list.append(self._avg)
        
    def num(self):
        self._num = self._list[0]
        return self._num

    def name(self):
        self._name = self._list[1]
        return self._name

    def kor(self):
        self._kor = self._list[2]
        return self._kor

    def eng(self):
        self._eng = self._list[3]
        return self._eng

    def math(self):
        self._math = self._list[4]
        return self._math

    def total(self):
        self._total = self._list[5]
        return self._total

    def avg(self):
        self._avg = self._list[6]
        return self._avg


class StudentGradeSystem():
    
    def __init__(self,score_file): #생성자
        self._score_file = score_file
        self._students = []
        self._class_avg = 0.0
        self._kor_avg = 0.0
        self._eng_avg = 0.0
        self._math_avg = 0.0
        self._register_student()

    def _register_student(self): #학생 객체 생성
        f = open(self._score_file, 'r')
        for i in range(0,10):
            line = f.readline()
            result = line.split(',')
            
            self._students.append(result)
        f.close()
        


    def _calculate_class_avg(self): #반 평균
        result = 0 
        for i in range(0, 10):
            result = result + int(self._students[i][5])
        self._class_avg = result / 10.0
        print('반 평균: ',self._class_avg)
        
    def _calculate_kor_avg(self): #언어 평균
        result = 0
        for i in range(0, 10):
            result = result + int(self._students[i][2])
        self._kor_avg = result / 10.0
        print('국어 평균: ',self._kor_avg)

    def _calculate_eng_avg(self): #영어 평균
        result = 0
        for i in range(0, 10):
            result += int(self._students[i][3])
        self._eng_avg = result / 10.0
        print('영어 평균: ',self._eng_avg)

    def _calculate_math_avg(self): #수학 평균
        result = 0
        for i in range(0, 10):
            result += int(self._students[i][4])
        self._math_avg = result / 10.0
        print('수학 평균: ',self._math_avg)

    

    def output_result(self, result_file): # 성적 처리된 결과를 파일로 출력
        self._result_file = result_file
        
        for i in range(0,10):
            self.stu = Student(self._students[i])
            self.stu._calculate_total()
            self.stu._calculate_avg()
            
     
        
        for i in range(0, 10):
            for k in range(i+1, 10):
                if (self._students[i][5] < self._students[k][5]):
                    temp = self._students[i]
                    self._students[i] = self._students[k]
                    self._students[k] = temp
     
        
        f = open(self._result_file, 'a')
        for i in range(0,10):
            self.stu = Student(self._students[i])
            self.stu._calculate_total()
            self.stu._calculate_avg()
            data = "번호: %d, 이름: %s, 국어: %d, 영어: %d, 수학: %d, 총점: %d, 평균: %.2lf \n" %(int(self.stu.num()), self.stu.name(), int(self.stu.kor()), int(self.stu.eng()), int(self.stu.math()), int(self.stu.total()), float(self.stu.avg()))
            f.write(data)    
        f.close()

        

    def _calculate_class_information(self): # 반 평균, 언어평균, 수학평균, 영어 평균 출력
        self._calculate_class_avg()
        self._calculate_kor_avg()
        self._calculate_eng_avg()
        self._calculate_math_avg()


    def process(self): # 학생 순위 출력, 출력메소드 실행
        self._calculate_class_information()
        
def main(): #메인 메소드
    student_grade_system = StudentGradeSystem('score.csv')
    student_grade_system.output_result('result.csv')
    student_grade_system.process()
    
main()



























