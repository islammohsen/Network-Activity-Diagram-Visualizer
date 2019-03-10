import java.math.*;
import java.util.*;
import java.io.*;

Map<String, Integer> maping = new HashMap<String, Integer>();
Integer getkey(String s)
{
  if(maping.containsKey(s))
    return maping.get(s);
   maping.put(s, maping.size());
   return maping.get(s);
}

final Integer MaxNumberOfNodes = 25;
Vector<Node> Nodes = new Vector<Node>();
int []In = new int[MaxNumberOfNodes];
int []Out = new int[MaxNumberOfNodes];
Vector<Vector<Integer>> graph = new Vector<Vector<Integer>>();
int ActivityWidth = 200, ActivityHeight = 150, DeltaWidth = 200, DeltaHeight = 50;
BufferedReader reader;

void setup()
{
  for(int i = 0; i < MaxNumberOfNodes; i++) //<>//
  {
    graph.add(new Vector<Integer>());
  }
  size(1500, 800);
  reader = createReader("commands.txt");
}

void draw()
{
  background(255);
  DrawNodes();
  HandleInput();
}

void HandleInput()
{
  String Line;
  try{
    Line = reader.readLine();
  }
  catch (IOException e) {
    e.printStackTrace();
    Line = null;
  }
  if(Line != null)
  {
    Scanner Input = new Scanner(Line);
    int Type = Input.nextInt();
    if(Type == 1)
    {
      String ActivityName = Input.next();
      int Duration = Input.nextInt();
      AddNode(ActivityName, Duration);
    }
    if(Type == 2)
    {
       String Activity1 = Input.next();
       String Activity2 = Input.next();
       AddDependecy(Activity1, Activity2);
    }
    Input.close();
  }
}

void AddNode(String Name, Integer Duration)
{
  Integer Id = getkey(Name);
  Nodes.add(new Node(Id, Name, Duration));
}

void AddDependecy(String Activity1, String Activity2)
{
  Integer Idx1 = getkey(Activity1);
  Integer Idx2 = getkey(Activity2);
  In[Idx1]++;
  Out[Idx2]++;
  graph.elementAt(Idx2).add(Idx1);
}

void DrawNode(Integer Idx, Integer X, Integer Y)
{
  rectMode(CENTER);
  fill(255);
  stroke(0);
  rect(X, Y, ActivityWidth, ActivityHeight);
  
  textAlign(CENTER, CENTER);
  textSize(32);
  fill(0);
  text(Nodes.elementAt(Idx).Name, X, Y);
  
  textAlign(CENTER, BOTTOM);
  textSize(32);
  fill(0);
  text(Nodes.elementAt(Idx).Duration, X, Y + ActivityHeight / 2);
}

void DrawNodes()
{
  Set<Integer> Current_Level = new HashSet<Integer>();
  for(Node CurrentNode: Nodes)
  { //<>//
    if(In[CurrentNode.Id] == 0)
      Current_Level.add(CurrentNode.Id);
  }
  int[][] Pos = new int[MaxNumberOfNodes][];
  for(int i = 0; i < MaxNumberOfNodes; i++)
    Pos[i] = new int[2];
  int X = ActivityWidth;
  while(Current_Level.size() > 0)
  {
    Set<Integer> New_Level = new HashSet<Integer>();
    int Y = ActivityHeight;
    for(Integer CurrentIndex: Current_Level)
    {
      DrawNode(CurrentIndex, X, Y);
      Pos[CurrentIndex][0] = X;
      Pos[CurrentIndex][1] = Y;
      Y = Y + ActivityHeight + DeltaHeight;
      for(Integer NewIndex: graph.elementAt(CurrentIndex))
        New_Level.add(NewIndex);
    }
    Current_Level = New_Level;
    X = X + ActivityWidth + DeltaWidth;
  }
  DrawLines(Pos);
}

void DrawLines(int[][] Pos)
{
  for(Node CurrentNode: Nodes)
  {
    int Index1 = CurrentNode.Id;
    for(Integer Index2: graph.elementAt(Index1))
    {
       fill(0);
       line(Pos[Index1][0] + ActivityWidth / 2, Pos[Index1][1], Pos[Index2][0] - ActivityWidth / 2, Pos[Index2][1]);
    }
  }
}
