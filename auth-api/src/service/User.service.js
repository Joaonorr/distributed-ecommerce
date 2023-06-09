import UserRepository from "../repository/User.repository.js";

/**
 * @class UserService
 * @description Classe responsável por implementar as regras de negócio da entidade User
 * @exports UserService
 * @access public
 * @version 1.0.0
 */
class UserService {

    async findByEmail(req, res) {

        const { email } = req.body;

        if (!email) {
            return res.status(400).json({ message: 'Email is required' });
        }

        try {
                
            const user = await UserRepository.findByEmail(email);

            if (user) {

                return res.status(200).json({
                    id: user.id,
                    userName: user.userName,
                    email: user.email,
                    createdAt: user.createdAt,
                });

            }

            return res.status(404).json({ message: 'User not found' });

        } catch (error) {

            return res.status(500).json({ message: error.message });

        }
    }

    async findById(req, res) {

        const { id } = req.params;

        if (!id) {
            return res.status(400).json({ message: 'Id is required' });
        }

        try {
                
            const user = await UserRepository.findById(id);

            if (user) {

                return res.status(200).json({
                    id: user.id,
                    userName: user.userName,
                    email: user.email,
                    createdAt: user.createdAt,
                });

            }

            return res.status(404).json({ message: 'User not found' });

        } catch (error) {

            return res.status(500).json({ message: error.message });

        }
    }
}

export default new UserService();