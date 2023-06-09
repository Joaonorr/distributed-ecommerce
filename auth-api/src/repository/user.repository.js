import User from "../models/user.models.js";

/**
 * @class UserRepository
 * @description Classe responsável por realizar as operações de acesso ao banco de dados
 * @exports UserRepository
 * @access public
 * @version 1.0.0
 * @example <caption>Exemplo de uso da classe</caption>
 * import UserRepository from '../repository/user.repository.js';
 * 
 * const user = await UserRepository.findByEmail('email@email.com');
 * 
 * if (user) {
 *      console.log(user.userName);
 * }
 * else {
 *      console.log('Usuário não encontrado');
 * }
 * 
 * @see https://sequelize.org/docs/v6/
 * 
 */
class UserRepository {

    async findByEmail(email) {
        try {

            return await User.findOne({ where: { email: email } });

        } catch (error) {

            console.log(error);

            return null;

        }
    }

    async findById(id) {
        try {

            return await User.findOne({ where: { id: id } });

        } catch (error) {

            console.log(error);

            return null;

        }
    }

}

export default new UserRepository();