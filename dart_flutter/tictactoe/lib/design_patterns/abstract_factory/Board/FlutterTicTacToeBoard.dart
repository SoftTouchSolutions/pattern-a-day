
import 'package:flutter/material.dart';
import 'package:tictactoe/design_patterns/abstract_factory/Board/ITicTacToeBoard.dart';
import 'package:tictactoe/design_patterns/abstract_factory/BoardSpace/ITicTacToeBoardSpace.dart';
import 'package:tictactoe/design_patterns/abstract_factory/BoardSpace/FlutterTicTacToeBoardSpace.dart';
import 'package:tictactoe/TicTacToeGame.dart';
import 'dart:math';


class FlutterTicTacToeBoard implements ITicTacToeBoard{
  TicTacToeGame _tictactoe;
  FlutterTicTacToeBoardSpace _space;

  FlutterTicTacToeBoard(TicTacToeGame tictactoe) { 
    this._tictactoe=tictactoe;
    this._space=this.getBoardSpace(); 
  }

  @override
  ITicTacToeBoardSpace getBoardSpace(){
    return new FlutterTicTacToeBoardSpace(this._tictactoe);
  }

  @override
  Widget render(){
    return Stack(
      children:<Widget>[
        Column(
          crossAxisAlignment: CrossAxisAlignment.center,
          mainAxisAlignment: MainAxisAlignment.center,
          children: <Widget>[
            Container(
              child: Center(child: Text('${this._tictactoe.winner}',
                style: TextStyle(fontSize: 45),
                textAlign: TextAlign.center,
              ),)
            ),
            for (var x in [0,1,2])
              Row(
                mainAxisAlignment: MainAxisAlignment.center,
                children: <Widget>[
                  for(var y in [0,1,2])
                    this._space.render(x*3+y)
                ],
              )
          ],
        ),
        LayoutBuilder(
          builder: (context,constraints){
            return
            Transform.rotate(
              angle: -pi / 4.0,
              alignment: AlignmentDirectional(1.55, 20.0),
              child:Divider(
                thickness: 3,
                indent: constraints.maxWidth-(constraints.maxWidth-150),
                endIndent: constraints.maxWidth-(constraints.maxWidth-150),
              ),
            );
          },
        )
      ]
    );
    
  }
}