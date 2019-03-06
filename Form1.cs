using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeteorGame
{
    public partial class Form1 : Form
    {
        static Bitmap canvas = new Bitmap(480, 320);
        Graphics gg = Graphics.FromImage(canvas);
        int PW, PH;
        Point Cpos;//カーソル座標
        int[] enX = new int[10];
        int[] enY = new int[10];
        Random rand = new Random();
        int RR;
        Boolean hitFlg;//true:当たった
        int ecnt, ex, ey;//爆発演出用
        long msgcnt;//メッセージ用カウンタ
        Boolean titleFlg;//true：タイトル表示中
        long score;
        Font myFont = new Font("Arial", 16);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pMeteor.Hide();
            pPlayer.Hide();
            pBG.Hide();
            pExp.Hide();
            pGameover.Hide();
            pMsg.Hide();
            pTitle.Hide();

            pBase.Image = canvas;

            initGame();//初期処理
        }

        private void initGame()
        {
            PW = 41;//自機の幅
            PH = 51;//自機の高さ
            RR = 70 / 2;//隕石の半径
            for(int i=0;i<10;i++)
            {
                enX[i] = rand.Next(1, 450);//隕石の初期配置座標
                enY[i] = rand.Next(1, 900) - 1000;
            }
            hitFlg = false;
            ecnt = 40;//爆発の初めの処理で位置を変更する
            msgcnt = 0;
            titleFlg = true;
            score = 0;
        }

        private void pBase_Click(object sender, EventArgs e)
        {
            if(titleFlg)
            {
                if(msgcnt>20)
                {
                    msgcnt = 0;
                    titleFlg = false;
                }
                return;
            }
            if(msgcnt>80)
            {
                initGame();
            }
        }

        private void dispTitle()
        {
            msgcnt++;
            //タイトル表示中の描画は、すべてここで行う
            gg.DrawImage(pBG.Image, new Rectangle(0, 0, 480, 320));
            gg.DrawImage(pTitle.Image, new Rectangle(70, 80, 350, 60));
            if(msgcnt%60>20)
            {
                gg.DrawImage(pMsg.Image, new Rectangle(110, 190, 271, 26));
            }
            pBase.Image = canvas;
        }

        private void playerExplosion()
        {
            ecnt+= 4;
            if(ecnt>40)
            {
                ecnt = 8;
                ex = Cpos.X + rand.Next(40);//爆発の位置を変更
                ey = 220 + rand.Next(50);
            }
            //爆発演出中の描画は、すべてここで行う
            gg.DrawImage(pBG.Image, new Rectangle(0, 0, 480, 320));
            for(int i=0;i<10;i++)
            {
                gg.DrawImage(pMeteor.Image, new Rectangle(enX[i], enY[i], RR * 2, RR * 2));
            }
            gg.DrawImage(pPlayer.Image, new Rectangle(Cpos.X, 220, PW, PH));
            gg.DrawImage(pExp.Image, new Rectangle(ex - ecnt / 2, ey - ecnt / 2, ecnt, ecnt));
            msgcnt++;
            if(msgcnt>60)
            {
                gg.DrawImage(pGameover.Image, new Rectangle(70, 80, 350, 60));
                if(msgcnt%60>20)
                {
                    gg.DrawImage(pMsg.Image, new Rectangle(110, 190, 271, 26));
                }
            }
            gg.DrawString("SCORE:" + score.ToString(), myFont, Brushes.White, 10, 10);
            pBase.Image = canvas;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(titleFlg)
            {
                dispTitle();
                return;
            }
            if(hitFlg)
            {
                playerExplosion();
                return;
            }
            gg.DrawImage(pBG.Image, new Rectangle(0, 0, 480, 320));

            //隕石の移動
            for(int i=0;i<10;i++)
            {
                enY[i] += 5;
                gg.DrawImage(pMeteor.Image, new Rectangle(enX[i], enY[i], RR * 2, RR* 2));
                if(enY[i]>pBase.Height)//画面外へ出たら上に戻す
                {
                    enX[i] = rand.Next(1, 450);
                    enY[i] = rand.Next(1, 300) - 400;
                }
            }
            Cpos = PointToClient(Cursor.Position);
            if(Cpos.X<0)
            {
                Cpos.X = 0;
            }
            if(Cpos.X>Width-PW)
            {
                Cpos.X = Width - PW;
            }
            gg.DrawImage(pPlayer.Image, new Rectangle(Cpos.X, 220, PW, PH));

            score++;
            gg.DrawString("SCORE:" + score.ToString(), myFont, Brushes.White, 10, 10);
            pBase.Image = canvas;
            hitCheck();
        }

        private void hitCheck()
        {
            int pcx = Cpos.X + (PW / 2);//自機の中心座標
            int pcy = 220 + (PH / 2);
            int ecx, ecy, dis;//自機と隕石の距離計算用

            
            for(int i=0;i<10;i++)
            {
                ecx = enX[i] + RR;
                ecy = enY[i] + RR;
                dis = (ecx - pcx) * (ecx - pcx) + (ecy - pcy) * (ecy - pcy);
                if(dis<RR*RR)
                {
                    hitFlg=true;
                    break;
                }
            }
        }
    }
}
