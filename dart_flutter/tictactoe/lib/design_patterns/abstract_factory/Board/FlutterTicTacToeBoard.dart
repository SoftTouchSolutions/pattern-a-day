
import 'package:tictactoe/design_patterns/abstract_factory/BoardSpace/ITicTacToeBoardSpace.dart';
import 'package:tictactoe/design_patterns/abstract_factory/BoardSpace/FlutterTicTacToeBoardSpace.dart';


class FlutterTicTacToeBoard implements ITicTacToeBoard{
  TicTacToeGame _tictactoe;
  FlutterTicTacToeBoardSpace _space;

  FlutterTicTacToeBoard(TicTacToeGame tictactoe) { 
    this._tictactoe=tictactoe;
    this._space=getBoardSpace(); 
  } 
  @overide
  ITicTacToeBoardSpace getBoardSpace(){
    return new FlutterTicTacToeBoardSpace(this._tictactoe);
  }

  @overide
  Widget render(){
    return Column(
        crossAxisAlignment: CrossAxisAlignment.center,
        mainAxisAlignment: MainAxisAlignment.center,
        children: <Widget>[
            Container(
              child: Center(child: Text('${_tictactoe.winner}',
                      style: TextStyle(fontSize: 45),
                      textAlign: TextAlign.center,
                    ),)
            ),
            for (var x in [0,1,2])
              Row(
                mainAxisAlignment: MainAxisAlignment.center,
                children: <Widget>[
                  for(y in [0,1,2])
                    _space.render(x*3+y)
                ],
              )
          ],
      ),)
    );

  }
}