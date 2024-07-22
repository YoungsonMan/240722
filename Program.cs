/**************************************************************************
 * 객체지향과 클래스 과제
 * 최연승
 * 과제 1. Character 클래스 선언하기
 * 과제 2. 몬스터와 플레이어 클래스 선언하기
 **************************************************************************/

// 과제 1 Character Class 선언하기
// Character 클래스를 선언하고, 클래스가 가져야 할 필드와 메서드는 아래와 같다.
// 필드: 레벨, 체력, 이동속도, 공격력
// 메서드: 전진, 후진, 좌회전(90도), 우회전(90도), 공격, 피격
// 제출형태
// C# 콘솔 프로젝트
// 개인 과제용 Git Repository 디렉토리 생성후 Push
// 디렉토리 이름: 내 제출일 6사 (EX. 240722)
using System.Runtime.CompilerServices;

class Character
{
    public int level;
    private int healthPoint;
    public float speed;
    public int damage;



    // 전진
    public void MoveForward(float speed)
    {
        // speed += 100;
        Console.WriteLine($"플레이어가 {speed}의 속도로 전진합니다.");
    }
    // 후진
    public void MoveBackward(float speed)
    {
        Console.WriteLine($"플레이어가 {speed}의 속도로 후진합니다.");
    }
    // 좌회전 
    public void MoveLeft(float speed)
    {
        Console.WriteLine($"플레이어가 좌(90도)회전후 {speed}의 속도로 전진합니다.");
    }
    // 우회전
    public void MoveRight(float speed)
    {
        Console.WriteLine($"플레이어가 우(90도)회전후 {speed}의 속도로 전진합니다.");
    }
    // 방향설정은 어떻게
    // 상하좌우 방향을 갖고 그걸 바꿀수 있도록

    public void Attack(int damage)
    {
        Console.WriteLine($"플레이어가 {damage}의 데미지를 입힙니다.");
    }
    public void GetAttacked(int damage)
    {
        Console.WriteLine($"플레이어가 {damage}만큼의 데미지를 입습니다.");
    }
}



namespace ObjectOrientedClassAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Character player = new Character();
            player.level = 10;
            player.damage = 30;
            player.speed = 5;


            // 테스트
            Console.WriteLine($"플레이어 레벨: {player.level}\n플레이어 dps: {player.damage}\n플레이어 이동속도: {player.speed}");

            player.MoveForward(player.speed);
            player.MoveBackward(player.speed);
            player.MoveLeft(player.speed);
            player.MoveRight(player.speed);

            player.Attack(player.damage);
            player.GetAttacked(player.damage);

        }
    }
}
