
import 'package:flutter/material.dart';
import 'package:tictactoe/TicTacToeGame.dart';
import 'package:tictactoe/design_patterns/abstract_factory/BoardLine/ITicTacToeBoardLine.dart';


class FlutterTicTacToeBoardLine implements ITicTacToeBoardLine{

  TicTacToeGame _tictactoe;
  FlutterTicTacToeBoardLine(TicTacToeGame tictactoe) { 
    this._tictactoe=tictactoe; 
  } 

  @override
  Widget render(){
    return Center(
      child: CustomPaint( //                       <-- CustomPaint widget
        size: Size(162, 162),
        painter: MyPainter(),
      ),
    );

  }
}

class MyPainter extends CustomPainter { //         <-- CustomPainter class
  @override
  void paint(Canvas canvas, Size size) {
    final p1 = Offset(0, 0);
    final p2 = Offset(162, 162);
    final paint = Paint()
      ..color = Colors.black
      ..strokeWidth = 4;
      canvas.drawLine(p1, p2, paint);  
  }

  @override
  bool shouldRepaint(CustomPainter old) {
    return false;
  }
}