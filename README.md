<h1 align="center">
마왕용사
</h1>

<h5 align="center">
어느날, 눈을 떠보니 마왕이었던 아빠가 죽어있어서 용사를 물리치러 갑니다!
</h5>
<p align="center">
    <img src="https://github.com/CBI777/MaWang/blob/Final/Readme_Img/image.png" width=700>
</p>

-------------------

## 👿 About this repository
This repository contains codes and game application of 마왕용사, a game created for EDGE Game Development Contest that was held in the second half of 2021.

This game was created by team of four university students, using Unity with C#.

마왕용사 is a roguelite game, featuring:
  - Battle using CTB system on 2D tile map
  - Stage transition using graph-node system.

--------------------

## 🚩 프로젝트 목표 및 의의

- 저희 팀은 다른 사람과 함께 협력하여 팀으로써 게임을 개발하는 것이 처음인 사람이 다수입니다.
- 이번 프로젝트를 진행하면서 게임 개발 및 협업 능력을 기르는 동시에, 재미있게 플레이가 가능한 게임을 개발하는 것을 목표로 두었습니다.
- 팀으로써 함께 게임을 만들어간다는 것에 있어서 여러가지 충돌을 겪었습니다.
- 생각했던 분위기의 방향, 게임의 시스템이 다르거나, 코드나 그래픽 부분이 서로 충돌하는 부분이 생기는 등, 진땀을 빼는 상황들이 많았습니다.
- 그러나 매주마다 이루어지는 회의와 근황보고 및 체계정립을 통해서 게임의 내용과 방향성을 잡는데에 성공했습니다.
- 
--------------------

## ✏ 기획

- 마왕용사는 크게 2가지 게임에서 모티브를 따왔습니다.

<img src="https://github.com/hyeon23/hyeon23/assets/77566434/c8ae282f-3ed8-4a1a-a21e-a75220e3793a" width=700>

- **아이작의 번제:** 2D 타일 내에서 움직이는 로그라이크 형태, 하나의 방 내에서 전투가 발생, 여러 패턴을 가지는 몬스터가 등장하고, 플레이어는 이러한 몬스터들을 물리쳐가는 형태의 게임 구조를 반영했습니다.

<img src="https://github.com/hyeon23/hyeon23/assets/77566434/eb613322-efa0-48aa-9841-00bd23e33c71" width=700>

- **슬레이 더 스파이어:** 각 방들의 연결 형태를 보고 자신이 진행할 방향을 결정할 수 있는 게임 시스템을 반영했습니다.

본 게임은 다음과 같은 기본적인 특징을 가집니다.
1. 한 스테이지가 일정 갯수의 방으로 이루어져 있으며, 스테이지는 총 3개가 존재.
2. 방의 배치와 루트를 미리 확인하고 내가 진행할 방향을 결정.
3. 한 스테이지의 마지막 방에는 반드시 보스가 있으며, 이 보스를 클리어 하는 것이 다음 스테이지로 넘어가는 조건.
4. 한 방을 클리어하면 돈과 보상을 얻으며, 각 방에서 등장하는 몬스터와 방의 모양은 랜덤. 각 방은 2D 타일맵으로 이루어짐.
 1) 일반 방 : 일반적인 적이 등장하며, 클리어하면 원하는 능력치를 소폭 증가시킬 수 있음.
 2) 엘리트 방 : 일반적인 적 보다 강한 중간보스가 등장. 클리어시 원하는 능력치를 어느정도 증가시키거나, 등급이 낮은 유물을 얻을 수 있음.
 3) 보스 방 : 일반적인 적들과는 비교가 안되는 강한 중간보스가 등장. 등급이 높은 유물을 얻을 수 있음.
 4) 회복 방 : 체력을 일정량 회복
 5) 상점 방 : 돈으로 보스를 제외한 다른 방의 보상 중 하나를 살 수 있음.
5. 유물은 최대 3개까지 장비할 수 있으며, 전투 중 언제라도 바꿔가며 장착할 수 있음. 각 유물은 각기 다른 공격 능력을 제공하거나, 패시브 적인 능력을 부여하여 줌.
6. 각 방에서의 공격과 이동은 능력치에 따라 Real time으로 쿨타임이 돌아가게 됨. 이러한 공격과 이동을 통해 적을 쓰러뜨리는 것이 목표.

## 📖 게임 스토리

저희 게임은 마왕이었던 아버지를 용사의 손에 잃어버린 마왕의 아들이 용사를 물리치러 복수를 하러가는 것이 주요 내용입니다.
용사에 의해 엉망이 된 마왕성에서 빠져나가 용사에게 복수를 하려는 주인공과, 용사에 대적하기에는 아직 힘이 모자라다며 주인공을 말리는 (전)마왕의 최측근들의 이야기를 그리고 있습니다.
1스테이지에서 아직 재건중인 마왕성에서 주인공의 탈출을 막으려는 (전)마왕의 부하들을 뿌리치고 나와,
2스테이지에서 용사가 있는 왕국까지 모험을 떠나고,
3스테이지에서 용사를 찾아 왕국 내부로 침투하는 것이 스토리의 대략적인 틀입니다.

--------------------
## Installation
> Download the zip file stored in repository and unzip it. Execute .exe file to start the game.
> > Note that this game only supports Korean for now.

--------------------
## 🕹 Manual
<pre>
Press <b><ins>WASD</ins></b> to move around.    
</pre>

<pre>
Press <b><ins>1, 2, 3</ins></b> keys on top of qwerty to change the weapon,
Press <b><ins>E</ins></b> to attack.
</pre>

<pre>
Press <b><ins>ESC</ins></b> to open menu for config and map
</pre>

- All enemies shows attack range before executing attack. Use this as a chance to attack them.

-  Every attack and move has a cooldown. Use UIs at the bottom-left corner to see the cooldown.

-  Most of attacks are effected by the 'direction arrow', which is displayed under every characters. Consider direction of character when performing attack.

<p align="center">
    <img src="https://github.com/CBI777/MaWang/blob/Final/Readme_Img/image%20(1).png" width=700>
</p>

- Every weapons have different abilities, and can be changed easily with 1, 2, 3. Manipulate them well to fight off enemies.
- Take rewards after every battle and strengthen yourself to fight the boss.

<p align="center">
    <img src="https://github.com/CBI777/MaWang/blob/Final/Readme_Img/image%20(2).png" width=700>
</p>

--------------------
## Final Fixes
---수정된 버그---
1. Save하고 title로 돌아왔을때 새로하기나 이어하기가 제대로 되지 않던 문제를 수정
2. 각 방에 있었던 level확인과 디버그 버튼들 제거
3. 맵용 디버그 버튼들 제거
4. clearPanel에 맵 이동 버튼 추가<<<
5. Something 수정<<<

---발견한 버그---
---밸런스 패치---
1. 방들의 확률 변경 (상점-5%, 회복-5%)
2. Elite Map1 변경
3. Enemy0 변경
4. Enemy1 변경
5. 작은 골렘들 hp 버프 (검은색->15, 노랑->10)
6. 엘리트 골렘 버프 (체력->35, 근접공격 속도를 0.4초로 변경)
7. 플레이어의 hp보상을 버프 (체력증가량 [2 혹은 4] -> [3 혹은 6])
--------------------

## 👥 참여 인원 및 역할 분담 👥
|[임창빈](https://github.com/CBI777) | [박경수](https://github.com/ABCSDFWLO) | [강동현](https://github.com/hyeon23) |
|:------------:|:------------:|:------------:|
| <img src="https://avatars.githubusercontent.com/u/97778404?v=4" width=200px alt="임창빈"/> | <img src="https://avatars.githubusercontent.com/u/76253761?v=4" width=200px alt="박경수"/> | <img src="https://avatars.githubusercontent.com/u/77566434?v=4" width=200px alt="강동현"/> |
| **Team Leader** | **Follower** | **Follower** |
| Game Client | Game Client / Designer | Designer & Dot Artist |
| InGame | InGame | Game Design & Asset Design |

